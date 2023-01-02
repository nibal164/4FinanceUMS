import "./CourseComponent.css";
type CoursePropsType = {
  name: string;
  description: string;
  creditNumber: number;
};

function CourseComponent(props: CoursePropsType) {
  return (
    <div className="course-component-container">
      <h2 className="course-name">{props.name}</h2>
      <h3 className="course-description">{props.description}</h3>
      <h4>Name of credits: {props.creditNumber}</h4>
    </div>
  );
}

export default CourseComponent;
