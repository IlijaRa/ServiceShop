# Functional requirements of the Service subsystem

This chapter lists and describes all user functionalities that are part of the Service subsystem.

## 1. Sending equipment repair requests

A customer who is registered in the system, and has a malfunction in the equipment he wants to repair, can use the service provided by the system. Fills in the form intended in the system for this type of request. The form contains fields for name, surname, equipment name, equipment model, description of the situation that occurred and led to the malfunction. Also, the client fills in the method of payment if the service is performed. Apart from payment, everything is filled in plain text. The client confirms the sending and waits for the service to answer in what time to bring the equipment.

## 2. Insight into requests received from customers and distribution of work to service technicians

When a client sends a request to a service, the only one who has access to it is the main service technician. Requests arrive in the Inbox where the Chief Service Provider has an overview of all requests. When filling out the request, the client had to indicate the method of payment for the service, so the chief service technician has insight into that information as well.
The operations that the main service technician can perform are:
• Request Search - The Chief Service Provider can search requests by parameters: request type, client name, client surname, arrival date, payment method indicated by the client.
• Delete request - It is also possible for the master service provider to delete any request. In this case, he must explain in free form why he rejected the request. This explanation will be included in the notification that will be sent to the client automatically.
• Add a reminder to a request - There is an option for the main service technician to mark a request so that you do not forget something about that request. The label would be in the form of a changed color of the request or a sticky note next to the request.
• Client account access - The master service provider has the ability to access the account that requires the service. Here you can see basic information, such as: name, surname, date of registration on the system, place of residence and city.
• Sending a message to the client - The main service provider can contact the client directly to e.g. agreed on a date when the client can bring repair equipment.
Distribution of work to service technicians:
The chief service technician decides to whom he will forward which request for execution. It will give more experienced repairers more complicated repairs, while it will give beginners custom-made jobs because they require less knowledge and skills. The main service technician will be able to choose the option to forward the request. When he does, the serviceman he has chosen will be able to access that request and see what the problem is. When the request reaches the service center, it is noted as "in progress".

## 3. Send feedback to the user

A service technician who solves a particular problem has the ability to be in direct contact with the user whose problem it solves. It can inform him in what condition the product is in, what is the type of defect (if there is a request for repair), etc ... Search finds the client and selects the option to send a message, then opens a window where you can contact the client. The message that arrives to the client is in the form of a notification. Through this mechanism, the service technician is in constant contact with the client. This provides some security and trust with the client, which is desirable.

## 4. Invoice generation and price calculation

A service technician who worked on a certain malfunction, when he finishes the work, should calculate the price of the entire work and generate an invoice. The steps that include this functionality are:
• Invoice Generation - Invoice generation is system-supported, so the service technician can access a form that is designed for just that. Fills in the company name, address and all other relevant information (it can put default values ​​for these fields so that it does not have to fill in the same all the time). The final price is added (obtained by adding the consumed material and the percentage of earnings).
• Search and selection of used equipment - Like a shopping cart system, the service technician adds all the materials he used during the repair. He selects them by clicking on the thumbnail of the equipment that came out as a result of the search. Selection continues as long as the service technician has the materials to be selected. He has the ability to clear all selections and start over. If the service technician worked with the custommade request, he selects the components that are implemented in the computer.
• Percentage of earnings - Since the store must earn to pay for the work of all service technicians, and generally all employees in the store, there is a percentage of earnings that is added to the total amount of repairs or custommade.
• Final formula - The final price is obtained when the sum of the consumed material and the percentage of earnings are added. This price will eventually be displayed in the generated invoice created by the service technician.

## 5. Notice to Chief Service Provider

A message is sent to the chief service technician containing the generated invoice with the final price for the work done and some notice in the form of free text if there is a need to emphasize something. This message sets the user's request to the "finished" state.

## 6. Writing a report

After the work is completed, the service technician is obliged to write a report. In that report, he writes all the details that are important for the work done (problems he encountered, how he overcame them, etc.).
In the end, he gives an assessment for the general situation and for communication with the client, if there was any communication. If there were certain disagreements with the client, he emphasizes that as well.
The report compiled in this way is sent to the chief service technician.

## 7. Forwarding requests to admin

• Custommade request - In the case of a custommade request, the receipt of the report (4.4.6) and notification of the completed work (4.4.5), the main service provider is activated and forwards the admin generated invoice with the price. This document is accompanied by the main service provider, the method of payment that the client originally chose when sending the request. Now the admin has all the necessary information to determine the delivery of the equipment to the client. The administrator treats this request in the same way as the requests that come to him regarding the purchase by the client.
• Request for repair - If it is a repair, it is assumed that the request is submitted by customers who are in the same city as the service. Therefore, they can bring the equipment themselves and the admin does not organize delivery for them. The chief service technician arranges an appointment with them when they will pick up the equipment.
This functionality completes the complete process in which the service participates.
