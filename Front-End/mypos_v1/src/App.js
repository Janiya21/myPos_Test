import './App.css';
import ItemPage from "./pages/ItemPage";
import Layout from "./pages/Layout";
import {BrowserRouter, Routes, Route} from "react-router-dom";
import InvoicePage from "./pages/InvoicePage";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
            <Route index element={<InvoicePage />} />
            <Route path="invoice" element={<InvoicePage />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
