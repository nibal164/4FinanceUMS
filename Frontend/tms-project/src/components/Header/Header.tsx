import React from "react";
import "./Header.css";
import { useNavigate } from "react-router-dom";
import logo from "../../assets/b243b191-5085-41d7-aec3-6de645a21755.png";

function Header() {
  const navigate = useNavigate();
  return (
    <div className="header-container">
      <img
        onClick={() => navigate("/")}
        className="header-logo"
        src={logo}
        alt=""
      />
      <nav>
        <ul className="menu-ul">
          <li
            onClick={() => navigate("teachers-management")}
            className="menu-item"
          >
            Teachers Management
          </li>
          <li
            onClick={() => navigate("students-management")}
            className="menu-item"
          >
            Students Management
          </li>
          <li
            onClick={() => navigate("courses-management")}
            className="menu-item"
          >
            Courses Management
          </li>
        </ul>
      </nav>
    </div>
  );
}

export default Header;
