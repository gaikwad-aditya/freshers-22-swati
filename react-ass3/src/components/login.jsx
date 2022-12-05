import React, { useState } from "react";
import {Routes, Route, useNavigate} from 'react-router-dom'

const Login = () => {

    const navigate = useNavigate();

    const navigateToRegister = () => {
        navigate('/Registration')
    };

    const navigateToShowHotel = () => {
        navigate('/ShowhotelList')
    };

    const [email, setEmail] = useState('')
    const [password, setPassword] = useState('')

    const validateUser = () => {
        console.log(`Email-id = ${email}`)
        console.log(`Password = ${password}`)
    }

    const readEmail = (e) => {
        setEmail(e.target.value)
    }

    const readPassword = (e) => {
        setPassword(e.target.value)
    }

    return(
        <div className="mt-5 px-2 border container">
            <h6 className="Rheading">Login form</h6>
            <div className="mt-3">
                <label className="fl fontLabel" htmlFor="">Email-id:</label>
                <div className="new iconBox">
                    <i className="fa fa-user" aria-hidden="true"></i>
                </div>
                <input onChange={readEmail} type='email' className="textBox" placeholder="abc@gmail.com" />
            </div>

            <div className="mt-3">
                <label className="fl fontLabel" htmlFor="">Password:</label>
                <div className="fl iconBox">
                    <i className="fa fa-key" aria-hidden="true"></i>
                </div>
                <input onChange={readPassword} className="textBox" type='password' />
            </div>
            <div className="mt-3 mb-3 loginbtn">
                <button className="btn btn-success" onClick={navigateToShowHotel}>LOGIN</button>
            </div>
            <div className="fontLabel">
                <p>Don't have an account</p>
                <button className="Rbtn" onClick={navigateToRegister} >Register</button>
            </div>
        </div>
    )
}

export default Login