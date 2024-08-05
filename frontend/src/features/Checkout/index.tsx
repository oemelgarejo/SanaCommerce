import { IconArrowLeft, IconCheck } from "@tabler/icons-react";
import TotalLabel from "../../components/TotalLabel";
import style from "./Checkout.module.css";
import { useNavigate } from "react-router-dom";
import { useEffect, useState } from "react";
import { SanaAPI } from "../../api/sanaAPI";
import { useDispatch, useSelector } from "react-redux";
import { RootState } from "../../redux/store";
import { clearCart } from "../../redux/reducers/shoppingCartSlice";

function Checkout() {
  const [loading, setLoading] = useState(false);
  const [disabledButton, setDisabledButton] = useState(false);
  const [fullName, setFullName] = useState("");
  const [email, setEmail] = useState("");
  const navigate = useNavigate();
  const dispatch = useDispatch();
  const cartItems = useSelector((state: RootState) => state.shoppingCart.items);

  const handleBack = () => {
    navigate("/cart");
  };

  useEffect(() => {
    setDisabledButton(!fullName || !email);
  }, [fullName, email]);

  const handleCheckout = async () => {
    setLoading(true);
    try {
      const items = cartItems.map(({ product, quantity }) => ({
        productId: product.id,
        quantity,
      }));
      const { data } = await SanaAPI.post("/api/orders", {
        fullName,
        email,
        shoppingCartItems: items,
      });
      if (data) {
        dispatch(clearCart());
        navigate("/");
      }
    } catch (error) {
      console.log(error);
    } finally {
      setLoading(false);
    }
  };

  return (
    <div className="container">
      <div className={style.header}>
        <h4>Total Items:</h4>
        <TotalLabel />
      </div>
      <div style={{ marginTop: "10px" }}>
        <h4 style={{ marginBottom: "10px" }}>Customer</h4>
        <div className={style.form}>
          <div className={style.group}>
            <label>FullName</label>
            <input
              type="text"
              value={fullName}
              onChange={(e) => setFullName(e.target.value)}
            />
          </div>
          <div className={style.group}>
            <label>Email</label>
            <input
              type="text"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />
          </div>
        </div>
        <div className={style.actions}>
          <button className={style.btn} onClick={handleBack}>
            <IconArrowLeft style={{ width: 14, height: 14 }} />
            Back
          </button>
          <button
            className={style.btn}
            onClick={handleCheckout}
            disabled={loading || disabledButton}
          >
            {loading ? (
              "Processing..."
            ) : (
              <>
                Checkout
                <IconCheck style={{ width: 14, height: 14 }} />
              </>
            )}
          </button>
        </div>
      </div>
    </div>
  );
}

export default Checkout;
