import React, { useState } from "react";

const Registration = () => {

    const [firstname, setFirstname] = useState('')
    const [lastname, setLastname] = useState('')
    const [phone, setPhone] = useState('')
    const [email, setEmail] = useState('')
    const [password, setPassword] = useState('')

    const validateUser = () => {
        console.log(`First Name = ${firstname}`)
        console.log(`Last Name = ${lastname}`)
        console.log(`Phone Number = ${phone}`)
        console.log(`Email-id = ${email}`)
        console.log(`Password = ${password}`)
    }


    const readFirstname = (e) => {
        setFirstname(e.target.value)
    }

    const readLastname= (e) => {
        setLastname(e.target.value)
    }

    const readPhone = (e) => {
        setPhone(e.target.value)
    }

    const readEmail = (e) => {
        setEmail(e.target.value)
    }

    const readPassword = (e) => {
        setPassword(e.target.value)
    }

    return(
        <div>
            
            
            <div className="container">
            <h6 className="Rheading">Registration form</h6>
                <div className="box">
                    <label htmlFor="firstName" className="fl fontLabel"> First Name: </label>
                    <div className="new iconBox">
                        <i className="fa fa-user" aria-hidden="true"></i>
                    </div>
                    <div className="fr">
                        <input type="text" onChange={readFirstname} name="firstName" placeholder="First Name" className="textBox" autofocus="on" />
                    </div>
                    <div className="clr"></div>
                </div>

                <div className="box">
                    <label htmlFor="lastName" className="fl fontLabel"> Last Name: </label>
                    <div className="new iconBox">
                        <i className="fa fa-user" aria-hidden="true"></i>
                    </div>
                    <div className="fr">
                        <input type="text" onChange={readLastname} name="lastName" placeholder="Last Name" className="textBox clr" autofocus="on" />
                    </div>
                    <div className="clr"></div>
                </div>

                <div class="box">
                    <label htmlFor="phone" className="fl fontLabel"> Phone No.: </label>
                    <div className="fl iconBox"><i className="fa fa-phone-square" aria-hidden="true"></i></div>
                    <div className="fr">
                        <input type="text" onChange={readPhone} required name="phoneNo" placeholder="Phone No." className="textBox" />
                    </div>
                    <div className="clr"></div>
    		    </div>

                <div class="box">
                    <label htmlFor="email" className="fl fontLabel"> Email ID: </label>
                    <div className="fl iconBox"><i className="fa fa-envelope" aria-hidden="true"></i></div>
                    <div className="fr">
                        <input type="email" onChange={readEmail} required name="email" placeholder="Email Id" className="textBox"/>
                    </div>
                    <div className="clr"></div>
    		    </div>

                <div class="box">
                    <label htmlFor="password" className="fl fontLabel"> Password </label>
                    <div className="fl iconBox"><i className="fa fa-key" aria-hidden="true"></i></div>
                    <div className="fr">
                        <input type="Password" onChange={readPassword} required name="password" placeholder="Password" className="textBox"/>
                    </div>
                    <div className="clr"></div>
    		    </div>

                <div class="box terms">
    				<input type="checkbox" name="Terms" required/> &nbsp; I accept the terms and conditions
    		    </div>

                <div className="box" >
    				<button className="btn btn-warning" onClick={validateUser}>SUBMIT</button>
    		    </div>
            
        </div>
        </div>
        
    )

}

export default Registration