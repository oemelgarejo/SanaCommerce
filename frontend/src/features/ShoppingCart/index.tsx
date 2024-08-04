import { useDispatch, useSelector } from "react-redux";
import { ShoppingCartItem } from "../../api/types";
import { RootState } from "../../redux/store";
import ProductCart from "../../components/ProductCart";
import TotalLabel from "../../components/TotalLabel";
import style from "./ShoppingCart.module.css";
import { clearCart } from "../../redux/reducers/shoppingCartSlice";
import { useNavigate } from "react-router-dom";
//import { changeQuantity } from '../../redux/reducers/shoppingCartSlice';

function ShoppingCart() {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const cartItems = useSelector((state: RootState) => state.shoppingCart.items);

  const handleClearCart = () => {
    dispatch(clearCart());
  };

  const handleProcessOrder = () => {
    navigate("/checkout");
  };

  return (
    <div style={{ display: "flex", gap: 10 }}>
      <div className="container">
        <div className={style.shoppingCart}>
          <div>
            <div className={style.header}>
              <h2 className={style.title}>My Shopping Cart</h2>
              <a className={style.clearCart} onClick={handleClearCart}>
                Clear cart
              </a>
            </div>

            {cartItems.map((productItem: ShoppingCartItem) => (
              <ProductCart product={productItem} key={productItem.product.id} />
            ))}
          </div>
        </div>
      </div>
      <div className={style.containerDetails}>
        <h2 className={style.title}>My Shopping Cart</h2>
        <div style={{ height: "100%" }}>
          <div className={style.details}>
            <div style={{ paddingTop: "20px" }}>
              <div className={style.lineTotal}>
                <p>Items (6)</p>
                <TotalLabel />
              </div>
              <div className={style.lineTotal}>
                <p>Total</p>
                <TotalLabel />
              </div>
            </div>
          </div>
          <button
            style={{ width: "100%" }}
            disabled={cartItems.length === 0}
            onClick={handleProcessOrder}
          >
            Process Order
          </button>
        </div>
      </div>
    </div>
  );
}

export default ShoppingCart;
