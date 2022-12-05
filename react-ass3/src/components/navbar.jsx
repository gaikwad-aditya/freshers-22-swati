import { NavLink } from 'react-router-dom'
                       
export const Navbar = ()  => {
    return (
        <nav>
            <NavLink to='/'>Home</NavLink>
          
            <NavLink to='/Login'>Login</NavLink>

            <NavLink to='/Showhotellist'>Show Hotels</NavLink>

            <NavLink to='/addhotel'>Add Hotels</NavLink>
       </nav>
    )
}
  
