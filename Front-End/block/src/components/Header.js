import React from 'react'
import { useState, useEffect } from "react"
import { Link } from 'react-router-dom'

import logo from '../assets/block_logo.png'


export default function Header() {
    return (
        <div>
            <nav>
                <img src={logo} alt="Block time logo" />

                <ul>
                    <li><Link to='/administrador'>Administrador</Link></li>
                    <li><Link to='/clientes'>Administrador</Link></li>
                    <li><Link to='/dashboard'>Dashboard</Link></li>
                    <li><Link to='/'>Logout</Link></li>
                </ul>
            </nav>
        </div>
    )
}