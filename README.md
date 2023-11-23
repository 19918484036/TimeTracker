# TimeTracker
## This is a small working time recorder that helps us record daily working hours and display work records.
### Including two interfaces: Home and Record.
### In the Home interface, we can see a simple clock dial. Under the clock dial, you can select today’s working time. After selecting, click submit to submit.
![image](https://github.com/19918484036/TimeTracker/assets/61899012/5cdfdb8b-0d96-40bc-b704-e863cac091e1)

### In the Record interface, we can see all submitted working time records, and the latest records will be typed at the top. You can choose to delete a record.
![image](https://github.com/19918484036/TimeTracker/assets/61899012/9bdf9276-a86b-49cb-ab00-6ef5197aaca9)
![image](https://github.com/19918484036/TimeTracker/assets/61899012/3c0c6a4f-f0c1-4050-9207-746923b8e967)

## Briefly introduce the project structure
### The project is divided into three modules: Client, Server and Shared.
#### The more important ones in Shared module are RecordData.cs and ServiceResponse.cs.
record.cs is the database model of work records.
ServiceResponse.cs is a generic implementation of the service response class, packaging the information obtained from the database into the generic data Data in the ServiceResponse class, and attaching prompt information through the Success and Message fields.
![image](https://github.com/19918484036/TimeTracker/assets/61899012/fd26ece6-ae6c-4a74-be1e-04f5673cc15e)
![image](https://github.com/19918484036/TimeTracker/assets/61899012/7ddf6f50-d499-4439-b890-0eedcaf09694)

#### TimeTracker.Server
Use interface class IRecordService.cs.
Use the RecordService.cs class, inherit the IRecordService interface class, obtain data from the database, and encapsulate it into the ServiceResponse class.
Use TimeTracker.Server.Controllers.RecordController.cs. By calling the interface encapsulated by TimeTracker.Server.Services.RecordService above, register the HttpGet protocol to obtain data, and register the HttpPost protocol to send data, and register the HttpDel protocol to delete data
![image](https://github.com/19918484036/TimeTracker/assets/61899012/abbeb3bb-755c-47d9-baf9-fda0f91ae9c1)

#### TimeTracker.Client
Services include all data manipulation functions required by the front end. Shared includes components called by the front end.
![image](https://github.com/19918484036/TimeTracker/assets/61899012/d4bc4425-32d9-449d-88e4-5591559aebac)
