import { useDispatch, useSelector } from "react-redux";
import { AppDispatch, RootState } from "../../redux/store";
import { useEffect } from "react";
import {
  decrementPage,
  incrementPage,
  loadOrders,
} from "../../redux/reducers/orderSlice";
import { Order } from "../../api/types";

function OrderList() {
  const dispatch = useDispatch<AppDispatch>();

  const {
    items: orders,
    isLoading,
    error,
    pageNumber: currentPage,
    totalPages,
  } = useSelector((state: RootState) => state.orders);

  useEffect(() => {
    dispatch(loadOrders(currentPage));
  }, [dispatch, currentPage]);

  const handleNextPage = () => {
    dispatch(incrementPage());
  };

  const handlePrevPage = () => {
    dispatch(decrementPage());
  };

  return (
    <div>
      {isLoading ? (
        <p>Loading...</p>
      ) : error ? (
        <p>Error: {error}</p>
      ) : (
        <>
          <table className="table">
            <thead>
              <tr>
                <th>Date</th>
                <th>Customer</th>
                <th>Products</th>
                <th>Total</th>
              </tr>
            </thead>
            <tbody>
              {orders?.map(({ id, orderDate, orderItems, customer }: Order) => (
                <tr key={id}>
                  <td>{new Date(orderDate).toDateString()}</td>
                  <td>{customer?.fullName}</td>
                  <td align="center">{orderItems.length}</td>
                  <td align="right">
                    $
                    {orderItems
                      .reduce((acc, item) => acc + item.total, 0)
                      .toFixed(2)}
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
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

export default OrderList;
