import React, { Component } from 'react';

/**
 * Строка таблицы
 */
class CurrencyRow extends Component {

    handleClick() {
        this.props.click(this.props.data.id);
    }

    render() {

        return (
            <tr onClick={this.handleClick} >
                <td>{this.props.data.CharCode}</td>
                <td>{this.props.data.NumCode}</td>
                <td>{this.props.data.Nominal}</td>
                <td>{this.props.data.Name}</td>
                <td>{this.props.data.Value}</td>
            </tr>
        )
    }
}



export default CurrencyRow;