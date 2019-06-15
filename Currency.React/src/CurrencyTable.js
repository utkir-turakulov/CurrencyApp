import React, { Component } from 'react';

import CurrencyRow from './CurrencyRow';

/**
 * Таблица валют
 */
class CurrencyTable extends Component {

    constructor(props) {
        super(props);
        this.state =  {
            loaded: false
        }
    }

    componentDidMount() {
        this.setState({
            loaded: true
        });
    }

    componentDidUpdate() {
    }

    fillTable(data) {
        var list = [];

        for (var item in data) {
            list.push(data[item]);
        }

        return list;
    }

    handleSelect(id) {
        this.props.onUserSelected(id);
    }

    render() {
        var UsersData = [];

        if (this.props.data !== null) {
            this.fillTable(this.props.data).forEach(function (currencyData,id) {
                UsersData.push(<CurrencyRow key={id} data={currencyData} click={this.handleSelect} />);
            }.bind(this));
        }

        if (this.state.loaded && (UsersData !== null || UsersData !== undefined) && UsersData.length > 0) {
            return (
                <table className="table table-striped table-bordered user-list">
                    <thead>
                        <tr>
                            <th className="text-center">Букв. код</th>
                            <th className="text-center">Цифр. код</th>
                            <th className="text-center">Единиц</th>
                            <th className="text-center">Валюта</th>
                            <th className="text-center">Курс к рублю</th>
                        </tr>
                    </thead>

                    <tbody>
                        {UsersData}
                    </tbody>
                </table>
            )

        } else if (UsersData.length === 0) {
            return (
                <p>Данные не найдены</p>
            )

        } else {
            return (
                <p>Загружаем данные...</p>
            )
        }
    }
}

export default CurrencyTable;