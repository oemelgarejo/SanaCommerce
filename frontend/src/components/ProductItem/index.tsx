import { useState } from "react";
import { useDispatch } from "react-redux";
import { Product } from "../../api/types";
import {
  addToCart,
  changeQuantity,
  //changeQuantity,
  removeToCart,
} from "../../redux/reducers/shoppingCartSlice";
import { IconMinus, IconPlus } from "@tabler/icons-react";
import style from "./style/ProductItem.module.css";

interface ProductProps {
  product: Product;
  quantity: number;
}

function ProductItem({ product, quantity }: ProductProps) {
  const [inputQuantity, setInputQuantity] = useState(quantity);
  const dispatch = useDispatch();
  const { title, stock, price, description } = product;

  const handleMinusQuantity = () => {
    const newQuantity = inputQuantity - 1;
    if (newQuantity >= 0) {
      setInputQuantity(newQuantity);
      dispatch(removeToCart(product));
    }
  };

  const handleAddToCart = () => {
    let newQuantity = inputQuantity + 1;

    if (newQuantity > product.stock) {
      newQuantity = product.stock;
    }
    setInputQuantity(newQuantity);
    dispatch(addToCart(product));
  };

  const handleChangeQuantity = (e: React.ChangeEvent<HTMLInputElement>) => {
    let newQuantity = Number(e.target.value);

    if (newQuantity > product.stock) {
      newQuantity = product.stock;
    }
    setInputQuantity(newQuantity);
    dispatch(
      changeQuantity({
        product: product,
        quantity: Number(e.target.value),
      })
    );
  };

  return (
    <div className={style.product}>
      <div>
        <h3 className={style.title}>{title}</h3>
        <p>{description}</p>

        <p className={`${stock > 0 ? style.available : style.outStock}`}>
          Stock: {stock}
        </p>
      </div>
      <div className={style.productQuantity}>
        <p>${price}</p>
        <div className={style.productActions}>
          <button
            className={`mini ${style.buttonLeft}`}
            onClick={handleMinusQuantity}
          >
            <IconMinus style={{ width: 24, height: 24 }} stroke={1.5} />
          </button>
          <input
            type="number"
            value={inputQuantity}
            onChange={handleChangeQuantity}
            min={1}
            max={stock}
          />
          <button
            className={`mini ${style.buttonRight}`}
            onClick={handleAddToCart}
          >
            <IconPlus />
          </button>
        </div>
      </div>
    </div>
  );
}

export default ProductItem;
