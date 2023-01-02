import React from "react";
import "./DeletePopup.css";
import { Button } from "@mui/material";
import { useDispatch } from "react-redux";
import { deleteTeacherRequest } from "../../store/thunks/TeachersThunk";

type DeletePopupProp = {
  id: string;
  name: string;
  closePopup: any;
};
function DeletePopup(props: DeletePopupProp) {
  const dispatch = useDispatch<any>();

  return (
    <div>
      {/* overlay */}
      <div onClick={props.closePopup} className="delete-popup-overlay"></div>
      <div className="delete-popup-content">
        <h2>Are you sure you want to delete {props.name} teacher?</h2>
        <div className="delete-popup-header">
          <Button
            color="primary"
            variant="contained"
            type="submit"
            onClick={props.closePopup}
          >
            Cancel
          </Button>
          <Button
            color="error"
            variant="contained"
            type="submit"
            onClick={() =>
              dispatch(deleteTeacherRequest(props.id, props.closePopup))
            }
          >
            Delete
          </Button>
        </div>
      </div>
    </div>
  );
}

export default DeletePopup;
