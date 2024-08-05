import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import { Order } from "../../api/types";
import { SanaAPI } from "../../api/sanaAPI";

interface ApiResponse {
  orders: Order[];
  totalPages: number;
}

export const loadOrders = createAsyncThunk<ApiResponse, number>(
  "loadProducts",
  async (pageNumber = 1) => {
    const { data } = await SanaAPI.get(`/api/orders?pageNumber=${pageNumber}`);

    return data;
  }
);

export interface OrderResult {
  items: Order[];
  isLoading: boolean;
  error: null | string | undefined;
  pageNumber: number;
  totalPages: number;
}
const initialState: OrderResult = {
  items: [],
  isLoading: false,
  error: null,
  pageNumber: 1,
  totalPages: 1,
};

const orderSlice = createSlice({
  name: "orders",
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
  },
  extraReducers: (builder) => {
    builder.addCase(loadOrders.pending, (state) => {
      state.isLoading = true;
    });
    builder.addCase(loadOrders.fulfilled, (state, action) => {
      state.isLoading = false;
      const { orders, totalPages } = action.payload;
      state.items = orders;
      state.totalPages = totalPages;
    });
    builder.addCase(loadOrders.rejected, (state, action) => {
      state.isLoading = false;
      state.error = action.error.message as string;
    });
  },
});
export const { incrementPage, decrementPage } = orderSlice.actions;
export default orderSlice.reducer;
