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
//imports above

class SignupComponent extends React.Component{

  constructor(){
    super();
    this.state = {
      email: null,
      password: null,
      passwordVer: null,
      signupErr: ''
    };
  }

  render(){

    const { classes } = this.props; //saves properties in variable

    return(
      <main className={classes.main}>
        <CssBaseline></CssBaseline> //baseline css imported from material-UI
        <Paper className={classes.paper}> //paper is container with visual backdrop
          <Typography component='h1' variant='h5'>
            Sign up!
          </Typography>
          <form onSubmit={(e) => this.submitSignup(e)} className={classes.form}>
            <FormControl required fullWidth margin='normal'>
              <InputLabel htmlFor='signup-email-input'>Enter your email</InputLabel>
              <Input autoComplete='email' onChange={(e) => this.userTyping('email', e)} autoFocus id='signup-email-input'></Input>
            </FormControl>
            <FormControl required fullWidth margin='normal'>
              <InputLabel htmlFor='signup-password-input'>Create A Password</InputLabel>
              <Input type='password' onChange={(e) => this.userTyping('password', e)} id='signup-password-input'></Input>
            </FormControl>
            <FormControl required fullWidth margin='normal'>
                <InputLabel htmlFor='signup-password-confirmation-input'>Confirm Your Password</InputLabel>
                <Input type='password' onChange={(e) => this.userTyping('passwordConfirmation', e)} id='signup-password-confirmation-input'></Input>
            </FormControl>
            <Button type='submit' fullWidth variant='contained' color='primary' className={classes.submit}>SIGN UP</Button>
            {
              this.state.signupErr ?
              <Typography className={classes.errorText} component='h5' variant='h6'>
              {this.state.signupErr}</Typography>:
              null
            }
            <Typography component='h5' variant='h6' className={classes.hasAccountHeader}>Already have an account?</Typography>
            <Link className={classes.logInLink} to='/login'>Log in!</Link>
          </form>
        </Paper>
      </main>
    );
  }

  formIsValid = () => this.state.password === this.state.passwordVer; //test if password and password confirmation matches

  userTyping = (type, e) => { //update details when user is typing
    switch (type){
      case 'email':
      this.setState({ email: e.target.value});
      break;

      case 'password':
      this.setState({ password: e.target.value});
      break;

      case 'passwordConfirmation':
      this.setState({ passwordVer: e.target.value});
      break;

      default:
      break;
    }
    console.log(type, e);
  }

  submitSignup = (e) => {
    e.preventDefault();

    if(!this.formIsValid()){
      this.setState({ signupErr: 'Passwords do not match!'});
      return;
    }

    firebase  //imported direstore class
      .auth() //firebase authorization
      .createUserWithEmailAndPassword(this.state.email, this.state.password)  //built-in function
      .then(authRes => {  //save response to created user
        const userObj = {
          email: authRes.user.email //save user email from authRes
        };
        firebase  //imported firestore class
          .firestore()
          .collection('users')
          .doc(this.state.email)
          .set(userObj)
          .then(() => {
            this.props.history.push('/dashboard') //redirect to dashboard
          }, dbError => {
            console.log(dbError);
            this.setState({ signupErr: 'Failed to add user.'});
          })
      }, authError => {
        console.log(authError);
        this.setState({ signupErr: 'Failed to add user.'});
      })
  }
}

export default withStyles(styles)(SignupComponent); //add styles as property to SignupComponent
