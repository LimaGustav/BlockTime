import React from 'react'
import { useState, useEffect } from "react"
import { Link } from 'react-router-dom'

import logo from '../assets/block_logo.png'
import "./css/header.css"


export default function Header() {
    return (
        <div>
            <nav className='header_nav grid'>
                <img src={logo} alt="Block time logo" />

                <ul className='nav_links'>
                    <li><Link to='/administrador'>Administrador</Link></li>
                    <li><Link to='/clientes'>Clientes</Link></li>
                    <li><Link to='/dashboard'>Dashboard</Link></li>
                    <li><Link className='fa fa-sign-out fa-2x' to='/'></Link></li>
                </ul>
            </nav>
        </div>
    )
}