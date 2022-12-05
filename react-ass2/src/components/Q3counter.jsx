import React, { useState } from "react";

const Counter = () => {
    const [ counter, setCounter] = useState(0)

    const increment = () =>{
        console.log('incrementing...')
        setCounter(counter + 1)
        console.log(`counter = ${counter}`)
    }

    const decrement = () => {
        console.log('decrementing... ')
        setCounter(counter - 1)
        console.log(`counter = ${counter}`)
    }

    return(
        <div className="box">
            <button className="btn btn-success" onClick={increment}>+</button>
            <span className="bg-light mx-3 my-3 px-3 py-3">{counter}</span>
            <button className="btn btn-success" onClick={decrement}>-</button>
        </div>
    )
}

export default Counter