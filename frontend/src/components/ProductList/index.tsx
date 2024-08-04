import { useDispatch, useSelector } from "react-redux";
import { AppDispatch, RootState } from "../../redux/store";
import { useEffect } from "react";
import {
  decrementPage,
  incrementPage,
  loadProducts,
} from "../../redux/reducers/productSlice";
import ProductItem from "../ProductItem";
import { Product } from "../../api/types";
import { useNavigate } from "react-router-dom";

function ProductList() {
  const dispatch = useDispatch<AppDispatch>();
  const navigate = useNavigate();
  const {
    items: products,
    isLoading,
    error,
    pageNumber: currentPage,
    totalPages,
  } = useSelector((state: RootState) => state.products);

  const cartItems = useSelector((state: RootState) => state.shoppingCart.items);

  const getProductQuantity = (productId: string) => {
    const item = cartItems.find((item) => item.product.id === productId);
    return item ? item.quantity : 0;
  };

  useEffect(() => {
    dispatch(loadProducts(currentPage));
  }, [dispatch, currentPage]);

  const handleNextPage = () => {
    dispatch(incrementPage());
  };

  const handlePrevPage = () => {
    dispatch(decrementPage());
  };

  return (
    <div className="container">
      {isLoading ? (
        <p>Loading...</p>
      ) : error ? (
        <p>Error: {error}</p>
      ) : (
        <>
          <div style={{ display: "flex", justifyContent: "flex-end" }}>
            <button onClick={() => navigate("add-product")}>Add product</button>
          </div>

          {products.map((product: Product) => (
            <ProductItem
              key={product.id}
              product={product}
              quantity={getProductQuantity(product.id)}
            />
          ))}
        </>
      )}
      <div
        style={{
          display: "flex",
          justifyContent: "center",
          alignItems: "center",
          gap: 10,
        }}
      >
        <button onClick={handlePrevPage} disabled={currentPage === 1}>
          Previous Page
        </button>
        <span> Page {currentPage} </span>
        <button onClick={handleNextPage} disabled={currentPage === totalPages}>
          Next Page
        </button>
      </div>
    </div>
  );
}

export default ProductList;
