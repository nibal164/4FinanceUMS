import TeacherService from "../../services/teachersServices";
import { removeLoading, setLoading } from "../actions/loadingAction";
import {
  getAllTeachersSuccess,
  createTeachersSuccess,
  deleteTeachersSuccess,
  updateTeachersSuccess,
} from "../actions/TeachersAction";

export const getAllTeachersRequest = () => (dispatch: any) => {
  try {
    dispatch(setLoading());

    //API call
    TeacherService.getAllTeachers().then((response: any) => {
      //dispatch an action
      dispatch(getAllTeachersSuccess(response.data));
      dispatch(removeLoading());
    });
  } catch (error) {
    console.log("error", error);
  }
};

export const createTeacherRequest =
  (teacher: any, closePopup: any) => (dispatch: any) => {
    try {
      dispatch(setLoading());
      TeacherService.createTeacher(teacher).then(
        (response: any) => {
          console.log("response", response);
          dispatch(createTeachersSuccess(response.data));
          closePopup();
          dispatch(removeLoading());
        },
        (error: any) => {
          console.log("error", error);
          const message =
            (error.response &&
              error.response.data &&
              error.response.data.message) ||
            error.toString();
          console.log("message", message);
        }
      );
    } catch (error) {
      console.log("error", error);
      dispatch(removeLoading());
    }
  };

export const deleteTeacherRequest =
  (id: string, closePopup: any) => (dispatch: any) => {
    try {
      dispatch(setLoading());
      TeacherService.deleteTeacher(id).then(
        (response: any) => {
          console.log("response", response);
          dispatch(deleteTeachersSuccess(response.data.id));
          closePopup();
          dispatch(removeLoading());
        },
        (error: any) => {
          console.log("error", error);
          const message =
            (error.response &&
              error.response.data &&
              error.response.data.message) ||
            error.toString();
          console.log("message", message);
          dispatch(removeLoading());
        }
      );
    } catch (error) {
      console.log("error", error);
      dispatch(removeLoading());
    }
  };

export const updateTeacherRequest =
  (id: string, teacher: any, closePopup: any) => (dispatch: any) => {
    try {
      dispatch(setLoading());
      TeacherService.updateTeacher(id, teacher).then(
        (response: any) => {
          dispatch(updateTeachersSuccess(response.data));
          closePopup();
          dispatch(removeLoading());
        },
        (error: any) => {
          console.log("error", error);
          const message =
            (error.response &&
              error.response.data &&
              error.response.data.message) ||
            error.toString();
          console.log("message", message);
          dispatch(removeLoading());
        }
      );
    } catch (error) {
      console.log("error", error);
      dispatch(removeLoading());
    }
  };
