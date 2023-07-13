import React, { useEffect, useState } from "react";
import "./App.css";
import { IProduct } from "../../interfaces/product";

function App() {
  const [products, setProducts] = useState<IProduct[]>([]);

  useEffect(() => {
    fetch("http://localhost:5000/api/products")
      .then((res) => res.json())
      .then((data) => setProducts(data));
  }, []);

  function addProduct() {
    setProducts((prev) => [
      ...prev,
      {
        id: prev.length + 1,
        name: "test",
        price: prev.length * 100 + 100,
        brand: "brand",
        description: "description",
        pictureUrl: "url",
        type: "test",
        quantityInStock: 10,
      },
    ]);
  }
  return (
    <div className="App">
      <header className="App-header">
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
  );
}

export default App;
