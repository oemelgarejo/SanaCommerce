import { useState } from "react";
import { useDispatch } from "react-redux";
import { ShoppingCartItem } from "../../api/types";
import {
  changeQuantity,
  removeItem,
} from "../../redux/reducers/shoppingCartSlice";
import style from "./style/ProductCart.module.css";
import { IconTrash } from "@tabler/icons-react";

interface ProductCarProps {
  product: ShoppingCartItem;
}

function ProductCart({ product }: ProductCarProps) {
  const [quantity, setQuantity] = useState(product.quantity);
  const dispatch = useDispatch();
  const { title, stock, price, productCode } = product!.product;

  const handleRemoveItem = () => {
    dispatch(removeItem(product));
  };

  const handleChangeQuantity = (e: React.ChangeEvent<HTMLInputElement>) => {
    let newQuantity = Number(e.target.value);

    if (newQuantity > product.product.stock) {
      newQuantity = product.product.stock;
    }
    setQuantity(newQuantity);
    dispatch(
      changeQuantity({
        product: product.product,
        quantity: Number(e.target.value),
      })
    );
  };

  return (
    <div className={style.product}>
      <div>
        <h3 className={style.title}>{title}</h3>
        <p style={{ marginBottom: "5px" }}>{productCode}</p>
        <a className={style.removeLink} onClick={handleRemoveItem}>
          <IconTrash style={{ width: 16, height: 16 }} /> Delete
        </a>
      </div>
      <div className={style.productQuantity}>
        <p>${price}</p>
        <input
          type="number"
          value={quantity}
          onChange={handleChangeQuantity}
          min={1}
          max={stock}
        />
        <p>${(price * quantity).toFixed(2)}</p>
      </div>
    </div>
  );
}

export default ProductCart;
