import {Routes, Route, useNavigate} from 'react-router-dom'
import './App.css';
import Login from './components/login';
import Registration from './components/register';
import Addhotel from './components/addhotel';
import ShowhotelList from './components/showhotellist';
import { Navbar } from './components/navbar';
import Home from './components/home';

function App() {
  const navigate = useNavigate();



  return (
    <>
      < Navbar />
      <Routes>
        <Route path= '/' element={ <Home />} />
        <Route path= 'Login' element={ <Login />} />
        <Route path= 'Registration' element={ <Registration />} />
        <Route path= 'ShowhotelList' element={ <ShowhotelList />} />
        <Route path= 'addhotel' element={ <Addhotel />} />
      </Routes>
    </>
    
  );
}

export default App;
