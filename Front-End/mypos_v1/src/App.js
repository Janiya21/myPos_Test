import './App.css';
import ItemPage from "./pages/ItemPage";
import Layout from "./pages/Layout";
import {BrowserRouter, Routes, Route} from "react-router-dom";
import InvoicePage from "./pages/InvoicePage";
import ReportPage from "./pages/ReportPage";

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Layout />}>
            <Route index element={<ItemPage />} />
            <Route path="invoice" element={<InvoicePage />} />
            <Route path="report" element={<ReportPage />} />
        </Route>
      </Routes>
    </BrowserRouter>
  );
}

export default App;
