import { useState } from "react";
import style from "./style/AddProduct.module.css";
import { useNavigate } from "react-router-dom";
import { IconArrowLeft, IconCheck } from "@tabler/icons-react";
import { SanaAPI } from "../../../api/sanaAPI";
function AddProduct() {
  const [loading, setLoading] = useState(false);
  const [title, setTitle] = useState("");
  const [code, setCode] = useState("");
  const [description, setDescription] = useState<string | null>(null);
  const [price, setPrice] = useState(0);
  const [stock, setStock] = useState(0);
  const navigate = useNavigate();

  const handleBack = () => {
    navigate("/");
  };

  const handleCreateProduct = async () => {
    setLoading(true);
    try {
      const { data } = await SanaAPI.post("/api/products", {
        title,
        productCode: code,
        description,
        price,
        stock,
      });
      if (data) {
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
        <h4>Add product</h4>
      </div>
      <div className={style.form}>
        <div className={style.group}>
          <label>Title</label>
          <input
            type="text"
            value={title}
            onChange={(e) => setTitle(e.target.value)}
          />
        </div>
        <div className={style.group}>
          <label>Code</label>
          <input
            type="text"
            value={code}
            onChange={(e) => setCode(e.target.value)}
          />
        </div>
      </div>
      <div className={style.form}>
        <div className={style.group}>
          <label>Description</label>
          <input
            type="text"
            value={description ?? ""}
            onChange={(e) => setDescription(e.target.value)}
          />
        </div>
        <div className={style.group}>
          <label>Price</label>
          <input
            type="number"
            value={price}
            onChange={(e) => setPrice(Number(e.target.value))}
          />
        </div>
        <div className={style.group}>
          <label>Stock</label>
          <input
            type="number"
            value={stock}
            onChange={(e) => setStock(Number(e.target.value))}
          />
        </div>
      </div>
      <div className={style.actions}>
        <button className={style.btn} onClick={handleBack}>
          <IconArrowLeft style={{ width: 14, height: 14 }} />
          Back
        </button>
        <button className={style.btn} onClick={handleCreateProduct}>
          {loading ? (
            "Processing..."
          ) : (
            <>
              Create
              <IconCheck style={{ width: 14, height: 14 }} />
            </>
          )}
        </button>
      </div>
    </div>
  );
}

export default AddProduct;
