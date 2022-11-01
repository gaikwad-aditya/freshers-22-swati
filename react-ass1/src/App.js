
import './App.css';
import React, {Component} from 'react';
import First from './components/Q1'
// import Second from './components/Q2';
// import Third from './components/Q3';

class App extends Component{
  render(){
    return(
      <div className="App">
        < First />
        {/* < Second /> */}
        {/* < Third /> */}
      </div>
    )
  }
}


// function App() {
//   return (
//     <div className="App">
//       <Q1 />
//     </div>
//   );
// }

export default App;
