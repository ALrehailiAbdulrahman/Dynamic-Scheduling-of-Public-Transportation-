The system works based on real-time information, which will calculate the number of people in bus stations by using an IoT device (Raspberry Pi connected with camera), the calculation done by a camera in each bus station that takes pictures every interval of time and process these images by Raspberry Pi using pre-trained model object detection and gets the number of people that will be received in server to be tracked in the dashboard, this process will lead to indicate the status of the bus stop(no people, fewer people or people more than the capacity of bus), from this point the system will schedule the routes based on number of people in each station and trigger a bus to go and serve people in public transportation. The roads at which bus will move through have variant speed and traffic status, using the mathematical model we can calculate the estimated time of arrival in each bus stop. The process of system is prototyped and simulated using unity software engine for visualization. Our aim is to reduce the waiting time of passengers and save energy and scheduling buses in a convenient way. Scalability of the system will allow any types of improvements or adding sub-systems in future work.
