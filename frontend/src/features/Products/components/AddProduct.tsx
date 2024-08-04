import { useState } from "react";
import style from "./style/AddProduct.module.css";
import { useNavigate } from "react-router-dom";
import { IconArrowLeft, IconCheck } from "@tabler/icons-react";
function AddProduct() {
  const [fullName, setFullName] = useState("");
  const [email, setEmail] = useState("");
  const navigate = useNavigate();

  const handleBack = () => {
    navigate("/");
  };

  return (
    <div className="container">
      <div className={style.header}>
        <h4>Add product</h4>
      </div>
      <div className={style.form}>
        <div className={style.group}>
          <label>Title</label>
          <input
            type="text"
            value={fullName}
            onChange={(e) => setFullName(e.target.value)}
          />
        </div>
        <div className={style.group}>
          <label>Code</label>
          <input
            type="text"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </div>
      </div>
      <div className={style.form}>
        <div className={style.group}>
          <label>Description</label>
          <input
            type="text"
            value={fullName}
            onChange={(e) => setFullName(e.target.value)}
          />
        </div>
        <div className={style.group}>
          <label>Price</label>
          <input
            type="text"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
          />
        </div>
        <div className={style.group}>
          <label>Stock</label>
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
        <button className={style.btn}>
          <>
            Checkout
            <IconCheck style={{ width: 14, height: 14 }} />
          </>
        </button>
      </div>
    </div>
  );
}

export default AddProduct;
