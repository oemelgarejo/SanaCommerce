import { useSelector } from "react-redux";
import { RootState } from "../../redux/store";

function TotalLabel() {
  const cartItems = useSelector((state: RootState) => state.shoppingCart.items);
  const totalPrice = cartItems.reduce(
    (total, item) => total + item.quantity * item.product.price,
    0
  );
  return <>${totalPrice.toFixed(2)}</>;
}

export default TotalLabel;
