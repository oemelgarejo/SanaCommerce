import { configureStore } from "@reduxjs/toolkit";
import productsReducer from "./reducers/productSlice";
import shoppingCartReducer from "./reducers/shoppingCartSlice";
import orderReducer from "./reducers/orderSlice";

const store = configureStore({
  reducer: {
    products: productsReducer,
    shoppingCart: shoppingCartReducer,
    orders: orderReducer,
  },
});

export type AppDispatch = typeof store.dispatch;
export type RootState = ReturnType<typeof store.getState>;
export default store;
