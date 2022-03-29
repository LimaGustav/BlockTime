import React from 'react'
import { useState, useEffect } from "react"
import Header from '../components/Header'
import api from "../services/api"

import './css/listagemClientes.css'

export default function ListagemClientes() {
    return (
        <div>
            <Header/>

            <div className='cl_container'>
                <div className='cl_table_head'>
                    <span>Cliente</span>
                    <span>Descricao</span>
                    <span>Status</span>
                    <span>Contato</span>
                </div>
            </div>
        </div>
    )
}