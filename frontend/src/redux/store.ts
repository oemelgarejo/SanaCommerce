import { configureStore } from "@reduxjs/toolkit";
import productsReducer from "./reducers/productSlice";
import shoppingCartReducer from "./reducers/shoppingCartSlice";

const store = configureStore({
  reducer: {
    products: productsReducer,
    shoppingCart: shoppingCartReducer,
  },
});

export type AppDispatch = typeof store.dispatch;
export type RootState = ReturnType<typeof store.getState>;
export default store;
