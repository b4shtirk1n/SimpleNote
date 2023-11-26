import { useState } from "react";
import "../styles/auth.scss";

export default function Auth() {
  const [user, setUser] = useState({
    username: "",
    password: "",
  });

  async function onInput(e) {
    setUser({ ...user, [e.name]: e.value });
  }

  async function onSubmit(e) {
    e.preventDefault();
  }

  return (
    <>
      <div className="flex-column switch-container">
        <h1>SimpleNote</h1>
      </div>
      <div className="flex-column login-container">
        <h1>SingIn</h1>
        <form
          className="flex-column login-form"
          onSubmit={(e) => onSubmit(e.target)}
        >
          <div className="flex-column form-container">
            <label>Login</label>
            <input
              name="username"
              value={user.username}
              onChange={(e) => onInput(e.target)}
            />
          </div>
          <div className="flex-column form-container">
            <label>Password</label>
            <input
              name="password"
              value={user.password}
              onChange={(e) => onInput(e.target)}
            />
          </div>
          <div className="flex-column buttons-container">
            <button>SingIn</button>
            <button type="button">SingUp</button>
          </div>
        </form>
      </div>
    </>
  );
}
