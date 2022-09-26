import React from "react";
import { Link } from "react-router-dom";
import { Dropdown, Menu } from 'semantic-ui-react'

function Navbar() {
        return (
             <div class="ui inverted segment"  style={{marginTop:"0px", height:"8vh", marginBottom:"-30px"}}>
                       
                <div class="ui inverted secondary menu">
                    <a class="active item">
                        <Link to="/">Products</Link>
                    </a>
                    <a className="active item">
                        <Link to="/invoice">Invoice</Link>
                    </a>
                    <a className="active item">
                        <Link to="/">Reports</Link>
                    </a>
                </div>
            </div>
        );
}

export default Navbar;