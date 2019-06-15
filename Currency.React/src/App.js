import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import SearchBar from './SearchBar';
import CurrencyTable from './CurrencyTable';
var config = require('../config.js');

class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            data: null,
            filteredData: null,
            term: '',
            sortBy: '',
            sortOrder: '',
            filterText: ''
        };

        this.currencyData = {};
        this.handleUserInput.bind(this);

        this.load();
    }

    componentWillMount() {
        fetch(config.API_URL).then(res => res.json()).then(async (json) => {
            await this.setState({ data: json, term: '', filteredData: json }, (data) => {
                this.currencyData = json;
            });
        });
    }

    componentDidMount() {
        this.updateData();
    }

    load() {
        fetch(config.API_URL).then(res => res.json()).then(async (json) => {
            await this.setState({ data: json, term: '', filteredData: json }, (data) => {
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

    componentDidUpdate() {
        if (this.state.data !== null) {
            this.currencyData = this.state.data;
        }
    }

    handleUserInput(filterText) {
        this.setState({
            filterText: filterText
        }, function () {
            this.updateData()
        });
    }

    updateData() {
        var currencyData = [];

        if (this.state.data !== null) {
            this.fillTable(this.state.data.Valute).forEach(function (userData) {

                if (userData.CharCode !== null || userData.Name !== null) {
                    if (userData.Name.toUpperCase().indexOf(this.state.filterText.toUpperCase()) === -1 
                        && userData.CharCode.indexOf(this.state.filterText.toUpperCase()) === -1)
                            return;
                }
                currencyData.push(userData);

            }.bind(this));
        }

        this.setState({ filteredData: { Valute: currencyData } });
    }

    render() {
        if (this.state.data !== null) {
            return (

                <div className="App">
                    <div className="App-header">
                        <img src={logo} className="App-logo" alt="logo" />
                        <h4> Currency app</h4>
                    </div>
                    <p className="App-intro"> </p>

                    <div className="app container-fluid row">
                        <div className="col-sm-12 col-md-12 col-lg-12">
                            <header className="navbar-static-top">
                                <SearchBar
                                    filterText={this.state.filterText}
                                    onUserInput={this.handleUserInput.bind(this)}
                                />
                                <CurrencyTable
                                    data={this.state.filteredData.Valute}
                                    filterText={this.state.filterText}
                                    sortBy={this.state.sortBy}
                                    order={this.state.sortOrder}
                                    onUserSelected={this.handleActiveUser}
                                />
                            </header>
                        </div>

                        
                    </div>
                    <div className="content">

                    </div>
                </div>
            )
        }
        return (<div>No data</div>);

    }
};

export default App;

