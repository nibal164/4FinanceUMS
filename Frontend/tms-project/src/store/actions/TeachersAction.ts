export const GET_ALL_TEACHERS_SUCCESS = "GET_ALL_TEACHERS_SUCCESS";
export const getAllTeachersSuccess = (teachers: any) => ({
  type: GET_ALL_TEACHERS_SUCCESS,
  payload: teachers,
});

export const CREATE_TEACHERS_SUCCESS = "CREATE_TEACHERS_SUCCESS";
export const createTeachersSuccess = (teachers: any) => ({
  type: CREATE_TEACHERS_SUCCESS,
  payload: teachers,
});

export const DELETE_TEACHERS_SUCCESS = "DELETE_TEACHERS_SUCCESS";
export const deleteTeachersSuccess = (id: string) => ({
  type: DELETE_TEACHERS_SUCCESS,
  payload: id,
});

export const UPDATE_TEACHERS_SUCCESS = "UPDATE_TEACHERS_SUCCESS";
export const updateTeachersSuccess = (teacher: any) => ({
  type: UPDATE_TEACHERS_SUCCESS,
  payload: teacher,
});
