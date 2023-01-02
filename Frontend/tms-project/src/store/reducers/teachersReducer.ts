import {
  GET_ALL_TEACHERS_SUCCESS,
  CREATE_TEACHERS_SUCCESS,
  DELETE_TEACHERS_SUCCESS,
  UPDATE_TEACHERS_SUCCESS,
} from "../actions/TeachersAction";

const initialState = [] as any;

const TeachersReducer = (state = initialState, action: any) => {
  const { type, payload } = action;
  let tempArray = [] as any;

  switch (type) {
    case GET_ALL_TEACHERS_SUCCESS:
      return payload;

    case CREATE_TEACHERS_SUCCESS:
      return [...state, payload];

    case DELETE_TEACHERS_SUCCESS:
      tempArray = state.filter((teacher: any) => teacher.id !== payload);
      return tempArray;

    case UPDATE_TEACHERS_SUCCESS:
      let array = [...state];
      array.map((teacher: any, index: number) => {
        if (teacher.id == payload.id) {
          array[index] = payload;
        }
      });
      return array;

    default:
      return state;
  }
};

export default TeachersReducer;
