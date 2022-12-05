import React, { useState } from "react";
import starimg from './images/star-with-smiley-face.png'

const Rating = () => {
    const [rating, setRating] = useState(0)
    const [arr] = useState([])

    const showRating = () => {
        const n = arr.length
        if(n>0){
            for(let j=0; j<n; j++){
                arr.pop()
            }
        }
        for(let i=0; i< rating;i++){
            arr.push(i)
        }
        setRating(0)
    }

    return(
        <div>
            <h2 style={{margin:"20px"}}>Registration form</h2>
            <div>
                <div className="mt-3">
                    <label style={{margin:"15px"}} htmlFor="">Rating:</label>
                    <input onChange={(e)=>{setRating(Number(e.target.value))}} className="textBox" type='number' />
                </div>

                <div className="mt-3 mb-3">
                    <button className="btn btn-success" onClick={showRating}>Show Rating</button>
                </div>
            </div>

            <div>
                {arr.map((val)=>{
                    return(
                        <span>
                            <img style={{width:"50px", height:"50px"}} src={starimg} alt="star"></img>
                        </span>
                    )
                })}
            </div>

        </div>
    )
}

export default Rating