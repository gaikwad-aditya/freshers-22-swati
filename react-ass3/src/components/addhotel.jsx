import React, { useState } from "react";
import {Routes, Route, useNavigate} from 'react-router-dom';

const Addhotel = () => {
    const [RestaurantId, setRestaurantId] = useState()
    const [RestaurantName, setRestaurantName] = useState()
    const [RestaurantLandlineNo, setRestaurantLandlineNo] = useState()
    const [RestaurantAddress, setRestaurantAddress] = useState()
    const [RestaurantInformation, setRestaurantInformation] = useState()
    const navigate = useNavigate();

    //target value of RestaurantTd
    const onChangeRestaurantId = (event) => {
        setRestaurantId(event.target.value);
    };

    //target value of RestaurantName
    const onChangeRestaurantName = (event) => {
        setRestaurantName(event.target.value);
    };

    //target value of RestaurantLandlineNo
    const onChangeRestaurantLandlineNo = (event) => {
        setRestaurantLandlineNo(event.target.value);
    };

    //target value of RestaurantAddress
    const onChangeRestaurantAddress = (event) => {
        setRestaurantAddress(event.target.value);
    };

    //target value of RestaurantInformation
    const onChangeRestaurantInformation = (event) => {
        setRestaurantInformation(event.target.value);
    };

    function onSubmit() {
        const addHotels = JSON.parse(localStorage.getItem("addhotel") || "[]");
        const addhotel = {
            RestaurantId: RestaurantId,
            RestaurantName: RestaurantName,
            RestaurantLandlineNo: RestaurantLandlineNo,
            RestaurantAddress: RestaurantAddress,
            RestaurantInformation: RestaurantInformation,
            status:1
        };
        addHotels.push(addhotel);
        localStorage.setItem("addhotel", JSON.stringify(addHotels));
        window.alert("You have successfully Added hotel")
        navigate('/ShowhotelList')
    }

    const onLogOut = () => {
        navigate('/')
    }   
    return (
        <div>
            {/* <AdminDashboardnavbar/> */}
            <div class="col d-flex justify-content-center m-4">
                <div class="border border-primary p-5">
                    <h3 className='text-center'>Add Restaurant</h3>
                    <label className="m-1 row">Restaurant Id : </label>
                    <input type='number' value={RestaurantId} onChange={onChangeRestaurantId} class="m-1 row form-control" placeholder='Enter Restaurant Id'></input>
                    <label className="m-1 row">Restaurant Name : </label>
                    <input type='text' value={RestaurantName} onChange={onChangeRestaurantName} class="m-1 row form-control" placeholder='Enter Restaurant name'></input>
                    <label className="m-1 row">Landline No : </label>
                    <input type='number' value={RestaurantLandlineNo} onChange={onChangeRestaurantLandlineNo} class="m-1 row form-control" placeholder='Enter LandlineNo'></input>
                    <label className="m-1 row">Restaurant Address :</label>
                    <input type='text' value={RestaurantAddress} onChange={onChangeRestaurantAddress} class="m-1 row form-control" placeholder='Enter Address  '></input>        
                    <label className="m-1 row">Information About Restaurant :</label>
                    <textarea cols="30" value={RestaurantInformation} onChange={onChangeRestaurantInformation} rows="4 " class="m-1 row form-control" placeholder='loreum ipsum....'></textarea>
                    <div className="text-center">
                        <button class="row mt-2 btn btn-success row " onClick={onSubmit} type='submit'>Submit</button>
                    </div>
                </div>
            </div>
        </div>

    )
}

export default Addhotel