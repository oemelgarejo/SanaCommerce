import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { Product, ShoppingCartItem } from "../../api/types";

export interface ShoppingCart {
  items: ShoppingCartItem[];
}

const itemStored =
  localStorage.getItem("shoppingCartItems") !== null
    ? JSON.parse(localStorage.getItem("shoppingCartItems")!)
    : [];

const initialState: ShoppingCart = {
  items: itemStored,
};

const saveToLocalStorage = (items: ShoppingCartItem[]) => {
  localStorage.setItem("shoppingCartItems", JSON.stringify(items));
};

const shoppingCartSlice = createSlice({
  name: "shoppingCart",
  initialState,
  reducers: {
    addToCart: (state, action) => {
      const item = state.items.find(
        (item: ShoppingCartItem) => item.product.id === action.payload.id
      );

      if (item) {
        item.quantity += 1;
        if (item.quantity > item.product.stock) {
          item.quantity = item.product.stock;
        }
      } else {
        if (action.payload.stock >= 1) {
          state.items.push({ product: action.payload, quantity: 1 });
        }
      }

      saveToLocalStorage(state.items);
    },
    removeToCart: (state, action) => {
      const item = state.items.find(
        (item: ShoppingCartItem) => item.product.id == action.payload.id
      );

      if (item) {
        if (item.quantity === 1) {
          state.items = state.items.filter(
            (cartItem) => cartItem.product.id !== action.payload.id
          );
        } else {
          item.quantity -= 1;
        }
      }
      saveToLocalStorage(state.items);
    },
    changeQuantity: (
      state,
      action: PayloadAction<{ product: Product; quantity: number }>
    ) => {
      const item = state.items.find(
        (item: ShoppingCartItem) =>
          item.product.id === action.payload.product.id
      );
      const quantityValue =
        action.payload.quantity > action.payload.product.stock
          ? action.payload.product.stock
          : action.payload.quantity;

      if (item) {
        item.quantity = quantityValue;
      } else {
        state.items.push({
          product: action.payload.product,
          quantity: quantityValue,
        });
      }
      saveToLocalStorage(state.items);
    },
    removeItem: (state, action) => {
      state.items = state.items.filter(
        (item: ShoppingCartItem) =>
          item.product.id !== action.payload.product.id
      );
      saveToLocalStorage(state.items);
    },
    clearCart: (state) => {
      state.items = [];
      saveToLocalStorage(state.items);
    },
  },
});

export const {
  addToCart,
  removeToCart,
  changeQuantity,
  removeItem,
  clearCart,
} = shoppingCartSlice.actions;
export default shoppingCartSlice.reducer;
