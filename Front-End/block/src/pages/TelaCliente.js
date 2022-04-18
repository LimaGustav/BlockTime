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
                <div className='p_container_text'>
                    <p className='p_company_description'>Empresa especializada em desenvolvimento web</p>
                    <div className='p_container_problem'>
                        <p>Problema - Severidade</p>
                        <input readOnly className='p_input' type="text" />
                    </div>
                </div>
                <button type='submit' className='lgn_btn cl_btn p_btn'>Testar</button>
            </div>

        </div>
    );
}

export default Telacliente;
