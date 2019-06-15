import React, { Component } from 'react';


/**
 * Строка поиска
 */
class SearchBar extends Component {

    constructor(props) {
        super(props);
        this.state = { filterTex: '' };
        this.onChange = this.handleChange.bind(this);
        this.onUserInput = this.props.onUserInput;
    }

    handleChange() {
        this.props.onUserInput(
            this.refs.filterText.value
        );
    }

    render() {
        return (
            <div className="row">
                <div className="col-sm-12">
                    <div className="form-group searchbar">
                        <input
                            type="text"
                            placeholder="Поиск..."
                            className="form-control"
                            value={this.props.filterText}
                            ref="filterText"
                            onChange={this.handleChange.bind(this)}

                        />
                    </div>
                </div>
            </div>
        )
    }
}

export default SearchBar;