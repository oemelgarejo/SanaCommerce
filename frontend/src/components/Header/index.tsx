import { RootState } from "../../redux/store";
import { useSelector } from "react-redux";
import { Link } from "react-router-dom";

function Header() {
  const shoppingCart = useSelector(
    (state: RootState) => state.shoppingCart.items
  );
  return (
    <header>
      <nav>
        <ul>
          <li>
            <Link to="/">Catalog</Link>
          </li>
          <li>
            <Link to="/cart">Shopping Cart ({shoppingCart.length})</Link>
          </li>
          <li>
            <Link to="/orders">Orders</Link>
          </li>
        </ul>
      </nav>
    </header>
  );
}

export default Header;
