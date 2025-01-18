import { RouterProvider, createBrowserRouter } from "react-router-dom";
import "./App.css";
import { HomePage } from "./Pages/Home/Home";
import { LoginPage } from "./Pages/Login/LoginPage";

function App() {
  const router = createBrowserRouter([
    {
      path: "/",
      element: <HomePage />,
    },
    {
      path: "/login",
      element: <LoginPage />,
    },
    {},
  ]);

  return <RouterProvider router={router} />;
}

export default App;
