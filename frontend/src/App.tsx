import { Route, Routes } from "react-router-dom";
import Header from "./components/Header";
import ShoppingCart from "./features/ShoppingCart";
import Products from "./features/Products";
import Checkout from "./features/Checkout";
import AddProduct from "./features/Products/components/AddProduct";
import Orders from "./features/Orders";

function App() {
  return (
    <>
      <Header />
      <Routes>
        <Route path="/" element={<Products />} />
        <Route path="/add-product" element={<AddProduct />} />
        <Route path="/cart" element={<ShoppingCart />} />
        <Route path="/checkout" element={<Checkout />} />
        <Route path="/orders" element={<Orders />} />
      </Routes>
    </>
  );
}

export default App;
