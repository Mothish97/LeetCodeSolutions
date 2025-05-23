# Write your MySQL query statement below
select s.student_id,s.student_name ,sb.subject_name,COUNT(e.student_id)AS attended_exams
from Students s cross join Subjects sb 
left join Examinations e on e.subject_name = sb.subject_name and e.student_id = s.student_id
group by  s.student_id, s.student_name, sb.subject_name
order by  s.student_id, sb.subject_name 