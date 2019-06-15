import React, { Component } from 'react';
import Table from 'react-bootstrap/Table';

class Currency extends Component {

    constructor(props) {
        super(props);
        this.state = {
            weatherData: null,
            term: ''
        };

        this.currencyData = {};
        this.load();
    }

    componentWillMount() {
        const URL = "http://localhost:50175/api/Currency/Get";

        fetch(URL).then(res => res.json()).then(async( json )=> {
            await this.setState({ weatherData: json, term: ''}, (data) => {
               //console.log(this.state.weatherData);
               this.currencyData = json;
            });
        });
        
    }

    load() {
        const URL = "http://localhost:50175/api/Currency/Get";

        fetch(URL).then(res => res.json()).then(async (json) => {
            await this.setState({ weatherData: json, term: ''}, (data) => {
                //console.log(this.state.weatherData);
                this.currencyData = json;
            });
        });
    }

    fillTable(data) {
        var list = [];

        for (var item in data) {
            list.push(data[item]);
        }

        return list;
    }

    updateData(config) {
        this.setState(config);
    }

    componentDidMount() {
        console.log(this.state.weatherData);
    }

    componentDidUpdate() {
        if (this.state.weatherData !=null ) {
            console.log("обновлено");
            console.log(this.state.weatherData.Date);
            this.currencyData = this.state.weatherData;
        }
        
       // this.render();
    }

    render() {
        return (
            <Table striped bordered hover responsive="sm">
                <thead>
                    <tr>
                        <th>Букв. код</th>
                        <th >Цифр. код</th>
                        <th >Единиц</th>
                        <th >Валюта</th>
                        <th >Курс</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        this.fillTable(this.currencyData.Valute).map((val, key) => {
                            return (<tr key={key}>

                                <td>{val.CharCode}</td>
                                <td>{val.NumCode}</td>
                                <td>{val.Nominal}</td>
                                <td>{val.Name}</td>
                                <td>{val.Value}</td>
                            </tr>)
                        })
                    }
                    </tbody>
            </Table>
            )
        }
        
    }
    
    
export default Currency;