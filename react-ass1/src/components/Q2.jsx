import React from "react"

function Car(props) {
    console.log(props)

    const car = props.car
    return(
        <div>
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

const Second = () => {
    const cars = [
        {
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
        },
        {
            model: 'Venue',
            company: 'Hyundai',
            price: 12,
            configuration: {
                color: 'white',
                fuel: 'diesel',
                cylinder: 4,
                fuelTankCapacity: 37,
                mileage: {
                    city: 14,
                    highway: 20,
                },
            },
            features: ['touch screen', 'bluetooth', 'alloy wheels', 'power steering'],
        },
        {
            model: 'Ertiga',
            company: 'Maruti',
            price: 13,
            configuration: {
                color: 'red',
                fuel: 'petrol',
                cylinder: 4,
                fuelTankCapacity: 37,
                mileage: {
                    city: 14,
                    highway: 20,
                },
            },
            features: ['touch screen', 'bluetooth', 'alloy wheels', 'power steering'],
        },
        {
            model: 'Safari',
            company: 'TATA',
            price: 18,
            configuration: {
                color: 'black',
                fuel: 'petrol',
                cylinder: 4,
                fuelTankCapacity: 37,
                mileage: {
                    city: 14,
                    highway: 20,
                },
            },
            features: ['touch screen', 'bluetooth', 'alloy wheels', 'power steering'],
        },
        {
            model: 'Altroz',
            company: 'TATA',
            price: 13,
            configuration: {
                color: 'blue',
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
    ]

    return(
        <div>
            <h1>React assignment 1: Question 2</h1>

            {/* {cars.map((car) => {
                return<Car car = {car}/>
            })} */}

            <hr />
            <ul>
                {cars.map((car) => {
                    return (
                    <li>
                        <Car car={car} />
                    </li>
                )
                })}
            </ul>
        </div>
    )
}

export default Second