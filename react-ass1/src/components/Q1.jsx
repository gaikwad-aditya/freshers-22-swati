import React from 'react';

const First = () => {
    const car = {
            model: 'i20',
            company: 'Hyundai',
            price: 20,
            configuration: {
                color: 'gray',
                fuel: 'petrol',
                cylinder: 4,
                fuelTankCapacity: 37,
                mileage: {
                    city: 14,
                    highway: 20,
                },
            },
            features: ['touch screen', 'bluetooth', 'alloy wheels', 'power steering'],
        }
    return (
        <div>

            <h1>React assignment 1: Question 1</h1>

            <div>Model : {car.model}</div>
            <div>company : {car.company}</div>
            <div>price : {car.price}</div>
            <div>color : {car.configuration.color}</div>
            <div>fuel : {car.configuration.fuel}</div>
            <div>cylinder : {car.configuration.cylinder}</div>
            <div>fuelTankCapacity : {car.configuration.fuelTankCapacity}</div>
            <div>mileage-city : {car.configuration.mileage.city}</div>
            <div>mileage-highway : {car.configuration.mileage.highway}</div>
            <div>First-features : {car.features[0]}</div>
            <div>Second-features : {car.features[1]}</div>
            <div>Third-features : {car.features[2]}</div>
            <div>Fourth-features : {car.features[3]}</div>
        </div>
    )
}

export default First