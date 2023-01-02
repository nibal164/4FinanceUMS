import { Button, Grid, IconButton, TextField, Typography } from "@mui/material";
import React, { useState, useEffect } from "react";
import "./TeacherPopup.css";
import CloseIcon from "@mui/icons-material/Close";
import { useDispatch, useSelector } from "react-redux";

//thunk
import {
  createTeacherRequest,
  updateTeacherRequest,
} from "../../../store/thunks/TeachersThunk";

type TeacherPopupProps = {
  id?: string;
  closePopup: any;
};

type TeacherState = {
  name: string;
  email: string;
  specality: string;
};

function TeacherPopup(props: TeacherPopupProps) {
  const dispatch = useDispatch<any>();
  
  //redux state
  const teachers = useSelector((state: any) => state.TeachersReducer);
  
  const [teacher, setTeacher] = useState<TeacherState>({
    name: "",
    email: "",
    specality: "",
  });
  
  const [isSaveButtonDisabled, setSaveButtonDisabled] = useState(false);

  const getTeacherById = () => {
    return teachers.filter((teacher: any, index: number) => {
      if (teacher.id == props.id) {
        setTeacher(teachers[index]);
      }
    });
  };

  useEffect(() => {
    getTeacherById();
  }, []);

  const handleOnNameChange = (event: any) => {
    let value = event.target.value;
    setTeacher({ ...teacher, name: value });
  };

  const handleOnEmailChange = (event: any) => {
    let value = event.target.value;
    setTeacher({ ...teacher, email: value });
  };

  const handleOnSpecialtyChange = (event: any) => {
    let value = event.target.value;
    setTeacher({ ...teacher, specality: value });
  };

  const validator = () => {
    if (
      teacher.name === "" ||
      teacher.email === "" ||
      teacher.specality === ""
    ) {
      setSaveButtonDisabled(true);
    } else if (!ValidateEmail(teacher.email)) {
      setSaveButtonDisabled(true);
    } else {
      setSaveButtonDisabled(false);
    }
  };


  function ValidateEmail(mail: string) {
    if (/^\w+([\.-]?\w+)@\w+([\.-]?\w+)(\.\w{2,3})+$/.test(mail)){
      return true;
  }
  return false;
  }
  
  useEffect(() => {
    validator();
  }, [teacher]);

  const handleOnSubmit = () => {
    props.id
      ? dispatch(
          updateTeacherRequest(
            props.id,
            {
              name: teacher.name,
              specality: teacher.specality,
            },
            props.closePopup
          )
        )
      : dispatch(createTeacherRequest(teacher, props.closePopup));
  };

  return (
    <div className="teacher-popup-container">
      {/* overlay */}
      <div onClick={props.closePopup} className="teacher-popup-overlay"></div>
      <div className="teacher-popup-content">
        {/* Popup Header (Title + Close Icon) */}
        <div className="teacher-popup-header">
          <Typography variant="h3" color="primary">
            {props.id ? "Update Teacher" : "Create Teacher"}
          </Typography>
          <IconButton
            size="large"
            title="close icon"
            color="error"
            onClick={props.closePopup}
          >
            <CloseIcon />
          </IconButton>
        </div>

        <Grid container rowSpacing={2} columnSpacing={2}>
          <Grid item xs={12}>
            <TextField
              label="Teacher Name"
              variant="outlined"
              fullWidth
              name="name"
              value={teacher.name}
              onChange={handleOnNameChange}
            />

            <TextField
              label="Teacher Email"
              variant="outlined"
              fullWidth
              disabled={props.id ? true : false}
              name="email"
              value={teacher.email}
              onChange={handleOnEmailChange}
            />

            <TextField
              label="Teacher Specialty"
              variant="outlined"
              fullWidth
              name="specialty"
              value={teacher.specality}
              onChange={handleOnSpecialtyChange}
            />
          </Grid>
          <Grid item xs={12}>
            <Button
              color="primary"
              variant="contained"
              type="submit"
              disabled={isSaveButtonDisabled}
              onClick={handleOnSubmit}
            >
              Save
            </Button>
          </Grid>
        </Grid>
      </div>
    </div>
  );
}

export default TeacherPopup;
