﻿Feature: PreAuthorizedCodeErrors
	Check errors returned when using 'urn:ietf:params:oauth:grant-type:pre-authorized_code' grant-type

Scenario: client_id is required
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key        | Value                                                |
	| grant_type | urn:ietf:params:oauth:grant-type:pre-authorized_code	|

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_client'
	And JSON '$.error_description'='missing client_id'

Scenario: client must exists
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key        | Value                                                |
	| grant_type | urn:ietf:params:oauth:grant-type:pre-authorized_code	|
	| client_id  | invalid                                              |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_client'
	And JSON '$.error_description'='unknown client invalid'

Scenario: client must supports the grant-type
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key        | Value                                                |
	| grant_type | urn:ietf:params:oauth:grant-type:pre-authorized_code	|
	| client_id  | fiftySevenClient                                     |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_grant'
	And JSON '$.error_description'='grant type urn:ietf:params:oauth:grant-type:pre-authorized_code is not supported'

Scenario: pre-authorized code is required
	When execute HTTP POST request 'https://localhost:8080/token'
	| Key        | Value                                                |
	| grant_type | urn:ietf:params:oauth:grant-type:pre-authorized_code	|
	| client_id  | fiftyNineClient                                      |

	And extract JSON from body
	Then HTTP status code equals to '400'
	And JSON '$.error'='invalid_request'
	And JSON '$.error_description'='missing parameter pre-authorized_code'