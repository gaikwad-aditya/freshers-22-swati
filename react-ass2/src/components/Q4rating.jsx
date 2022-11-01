import React, { useState } from "react";
import starimg from './images/star-with-smiley-face.png'

const Rating = () => {
    const [rating, setRating] = useState(0)

    const readRating = (e) => {
        setRating(e.target.value)
    }

    const showRating = () => {
        console.log(`rating= ${rating}`)
        // for (let index = 1; index < rating; index++) {
        //         index= index + 3
        // }

        // console.log(`rating= ${rating}`)
    }

    return(
        <div>
            <div className="mt-3">
                <label className="fl fontLabel" htmlFor="">Rating:</label>
                <div className="fl iconBox">
                    <i className="fa fa-star" aria-hidden="true"></i>
                </div>
                <input onChange={readRating} className="textBox" type='number' />
            </div>

            <div className="mt-3 mb-3">
                <button className="btn btn-success" onClick={showRating}>Show Rating</button>
            </div>
            <img src={starimg} width='50' height={50} ></img>

        </div>
    )
}

export default Rating