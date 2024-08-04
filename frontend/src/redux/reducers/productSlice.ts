import { createAsyncThunk, createSlice, PayloadAction } from "@reduxjs/toolkit";
import { Product } from "../../api/types";
import { SanaAPI } from "../../api/sanaAPI";

interface ApiResponse {
  products: Product[];
  totalPages: number;
}

export const loadProducts = createAsyncThunk<ApiResponse, number>(
  "loadProducts",
  async (pageNumber = 1) => {
    const { data } = await SanaAPI.get(
      `/api/products?pageNumber=${pageNumber}`
    );

    return data;
  }
);

export interface ProductResult {
  items: Product[];
  isLoading: boolean;
  error: null | string | undefined;
  pageNumber: number;
  totalPages: number;
}
const initialState: ProductResult = {
  items: [],
  isLoading: false,
  error: null,
  pageNumber: 1,
  totalPages: 1,
};

const productSlice = createSlice({
  name: "products",
  initialState,
  reducers: {
    incrementPage: (state) => {
      state.pageNumber += 1;
    },
    decrementPage: (state) => {
      if (state.pageNumber > 1) {
        state.pageNumber -= 1;
      }
    },
    setPage: (state, action: PayloadAction<number>) => {
      state.pageNumber = action.payload;
    },
  },
  extraReducers: (builder) => {
    builder.addCase(loadProducts.pending, (state) => {
      state.isLoading = true;
    });
    builder.addCase(loadProducts.fulfilled, (state, action) => {
      state.isLoading = false;
      const { products, totalPages } = action.payload;
      state.items = products;
      state.totalPages = totalPages;
    });
    builder.addCase(loadProducts.rejected, (state, action) => {
      state.isLoading = false;
      state.error = action.error.message as string;
    });
  },
});

export const { incrementPage, decrementPage, setPage } = productSlice.actions;
export default productSlice.reducer;
