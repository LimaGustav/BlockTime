import React from 'react';
import Header from '../components/Header';

import './css/telaCliente.css'

const Telacliente = () => {
    return (
        <div>
            <Header />
            <div className='p_container grid'>

                <div className='p_container_title'>
                    <h1 className='p_title'>SypressTech</h1>
                    <i class="fas fa-edit fa-1x"></i>
                </div>
                <span>Empresa especializada em desenvolvimento web</span>

                <span>Problema - Severidade</span>
                <input type="text" />
                <button type='submit' className='lgn_btn cl_btn'>Testar</button>
            </div>

        </div>
    );
}

export default Telacliente;
