import React from 'react';
import { Link } from 'react-router-dom';
import FormControl from '@material-ui/core/FormControl';
import InputLabel from '@material-ui/core/InputLabel';
import Input from '@material-ui/core/Input';
import Paper from '@material-ui/core/Paper';
import withStyles from '@material-ui/core/styles/withStyles';
import CssBaseline from '@material-ui/core/CssBaseline';
import Typography from '@material-ui/core/Typography';
import Button from '@material-ui/core/Button';
import styles from './styles';

const firebase = require("firebase");

class LoginComponent extends React.Component{

  constructor(){
    super();
    this.state = {
      email: null,
      password: null,
      loginErr: ''
    };
  }

  render(){

    const { classes } = this.props;

    return(
      <main className={classes.main}>
        <CssBaseline></CssBaseline>
        <Paper className={classes.paper}>
          <Typography component='h1' variant='h5'>
            Log In!
          </Typography>
          <form className={classes.form} onSubmit={(e) => this.submitLogin(e)}>
            <FormControl required fullWidth margin='normal'>
              <InputLabel htmlFor='login-email-input'>Enter your email</InputLabel>
              <Input autoComplete='email' onChange={(e) => this.userTyping('email', e)} autoFocus id='login-email-input'></Input>
            </FormControl>
            <FormControl required fullWidth margin='normal'>
              <InputLabel htmlFor='login-password-input'>Enter your password</InputLabel>
              <Input type='password' onChange={(e) => this.userTyping('password', e)} id='login-password-input'></Input>
            </FormControl>
            <Button type='submit' fullWidth variant='contained' color='primary' className={classes.submit}>LOG IN</Button>
            {
              this.state.loginErr ?
              <Typography className={classes.errorText} component='h5' variant='h6'>
              {this.state.loginErr}</Typography>:
              null
            }
            <Typography component='h5' variant='h6' className={classes.hasAccountHeader}>Don't have an account?</Typography>
            <Link className={classes.signUpLink} to='/signup'>Sign Up!</Link>
          </form>
        </Paper>
      </main>
    );
  }

  userTyping = (type, e) => {
    switch (type){
      case 'email':
      this.setState({ email: e.target.value});
      break;

      case 'password':
      this.setState({ password: e.target.value});
      break;

      default:
      break;
    }
    console.log(type, e);
  }

  submitLogin = (e) => {
    e.preventDefault();

    firebase
      .auth()
      .signInWithEmailAndPassword(this.state.email, this.state.password)
      .then(() =>{
        this.props.history.push('/dashboard');
      }, err => {
        this.setState({ loginErr: 'Server error'});
        console.log('err');
      })
  }
}

export default withStyles(styles)(LoginComponent); //add styles as property to LoginComponent
