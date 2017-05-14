//class Button
//class Panel
//class App

class Toggle extends React.Component {
    constructor(props) {
        super(props);
        this.state = { isToggleOn: true };

        // This binding is necessary to make `this` work in the callback
        this.handleClick = this.handleClick.bind(this);
    }

    handleClick() {
        this.setState(prevState => ({
            isToggleOn: !prevState.isToggleOn
        }));
    }

    render() {
        return (
            <button onClick={this.handleClick}>
                {this.state.isToggleOn ? 'ON' : 'OFF'}
            </button>
        );
    }
}



class Clock extends React.Component {
    constructor(props) {
        super(props);
        this.state = {date: new Date()}
    }

    componentDidMount() {
        this.timerID = setInterval(
            () => this.tick(),
            1000
        );
    }

    componentWillUnmount() {
        clearInterval(this.timerID);
    }

    tick() {
        this.setState({
            date: new Date()
        });
    }

    render () {
        return (
            <div>
                <h1>Hello, world!</h1>
                <h2>It is {this.state.date.toLocaleTimeString()}.</h2>
            </div>
        );
    }
}



class Avatar extends React.Component {
    render() {
        return (
            <img className="Avatar"
                src={props.user.avatarUrl}
                alt={props.user.name}
            />
        );
    }
}



class Instrument extends React.Component {
    // This syntax ensures `this` is bound within handleClick.
    handleClick = () => {
        console.log('The link was clicked.');
    }

    render() {
        var instrumentStyle = {
            background: 'grey',
            margin: 10,
            fontFamily: "monospace",
            fontSize: "32"
        };

        return (
            <div className="instrument" style={instrumentStyle}>
                <img src={this.props.icon} />
                <h2 className="instrumentName">
                    {this.props.name}
                </h2>
                <button onClick={this.handleClick} className="btn btn-default">
                    Mute
                </button>
                <button onClick={this.handleClick} className="btn btn-default">
                    Solo
                </button>
            </div>
        );
    }
}



class InstrumentOld extends React.Component {
    rawMarkup() {
        var md = new Remarkable();
        var rawMarkup = md.render(this.props.children.toString());
        return { __html: rawMarkup };
    }

    render() {
        const style = {
            background: 'grey',
            margin: 0
        };

        return (
            <div className="instrument" style={style}>
                <img src={this.props.icon} />
                <h2 className="instrumentName">
                    {this.props.name}
                </h2>
                <span dangerouslySetInnerHTML={this.rawMarkup()} />
            </div>
        );
    }
}



class InstrumentList extends React.Component {
    render() {
        var instrumentNodes = this.props.data.map(function (instrument) {
            return (
                <Instrument name={instrument.name} key={instrument.id} icon={instrument.icon}>
                    {instrument.text}
                </Instrument>
            );
        });

        return (
            <div className="instrumentList">
                {instrumentNodes}
            </div>
        );
    }
}



class InstrumentForm extends React.Component {
    render() {
        return (
            <div className="instrumentForm">
                Hello, world! I am a InstrumentForm.
            </div>
        );
    }
}



class InstrumentBox extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            data: []
        }
    }

    loadInstrumentsFromServer() {
        var xhr = new XMLHttpRequest();
        xhr.open('get', this.props.url, true);
        xhr.onload = function () {
            var data = JSON.parse(xhr.responseText);
            this.setState({ data: data });
        }.bind(this);
        xhr.send();
    }

    componentDidMount() {
        this.loadInstrumentsFromServer();
        window.setInterval(this.loadInstrumentsFromServer, this.props.pollInterval);
    }

    render() {
        return (
            <div className="instrumentBox">
                <h1>Instruments</h1>
                <InstrumentList data={this.state.data} />
                <InstrumentForm />
                <Clock />
            </div>
        );
    }
}



ReactDOM.render(
    <InstrumentBox url="/instruments" pollInterval={2000} />,
    document.getElementById('content')
);