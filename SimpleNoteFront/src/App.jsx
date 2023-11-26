import { Route, Routes } from "react-router-dom";
import Header from "../components/Header";
import Footer from "../components/Footer";
import Auth from "../pages/Auth";
import "../styles/app.scss";

export default function App() {
  return (
    <>
      <Header />
      <Routes>
        <Route path="/" element={<Auth />} />
      </Routes>
      <Footer />
    </>
  );
}
