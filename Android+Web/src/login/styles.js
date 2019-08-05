const styles = theme => ({ //theme provided by materialUI
  main: { //class name
    width: 'auto',
    display: 'block',
    marginLeft: theme.spacing(3),
    marginRight: theme.spacing(3),
    [theme.breakpoints.up(400 + theme.spacing(3) * 2)]: {
      width: 400,
      marginLeft: 'auto',
      marginRight: 'auto',
    },
  },
  paper: { //class name
    marginTop: theme.spacing() * 8,
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    padding: `${theme.spacing(2)}px ${theme.spacing(3)}px ${theme.spacing()}`,
  },
  form: { //class name
    width: '100%',
    marginTop: theme.spacing(),
  },
  submit: { //class name
    marginTop: theme.spacing(3),
  },
  hasAccountHeader: { //class name
    width: '100%',
  },
  signUpLink: { //class name
    width: '100%',
    textDecoration: 'none',
    color: '#303f9f',
    fontWeight: 'bolder',
  },
  errorText: { //class name
    color: 'red',
    textAlign: 'center'
  }
});

export default styles;
