export interface Product {
  id: string;
  title: string;
  productCode: string;
  description: string;
  price: number;
  stock: number;
  productCategories: ProductCategory[];
}

export interface ProductCategory {
  productId: string;
  product: Product;
  categoryId: string;
  category: Category;
}

export interface Category {
  id: string;
  name: string;
  productCategories: ProductCategory[];
}

export interface Order {
  id: string;
  orderDate: string;
  customerId: string;
  customer: Customer;
  orderItems: OrderItem[];
}

export interface Customer {
  id: string;
  fullName: string;
  email: string;
  orders: Order[];
}

export interface OrderItem {
  orderId: string;
  order: Order;
  productId: string;
  product: Product;
  quantity: number;
}

export interface ShoppingCartItem {
  product: Product;
  quantity: number;
}
