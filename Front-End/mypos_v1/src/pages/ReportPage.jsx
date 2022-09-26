import React, { useState, useEffect } from 'react';
import '../assets/itemPage.css'
import {Grid, Table, Form, Input, Statistic, Button, Select, Icon, Image, Segment} from 'semantic-ui-react'

const ReportPage = () => {
    const [loading, setLoading] = useState(false);

    useEffect(() => {
        setLoading(true);
        setTimeout(() => {
            setLoading(false);
        }, 500);
    }, []);

    return (
        <div className="container" >
            {loading ? (
                <div className="loader-container">
                    <div className="spinner"/>
                    <h1 className={"header-shop"}>Loading ...</h1>
                </div>
            ) : (
                <div className="main-content" style={{marginLeft:"2vw"}}>
                    <Grid>
                        <Grid.Row>
                            <Form style={{marginTop:"30px"}}>
                                <Form.Group widths='equal' style={{marginLeft:"13vw"}}>
                                    <Form.Field
                                        id='form-input-control-desc'
                                        control={Input}
                                        label='Date'
                                        placeholder='2022-10-10'
                                    />
                                    <Form.Field
                                        control={Input}
                                        label='Invoice ID'
                                        placeholder='Invoice code'
                                        id='form-input-control-name'
                                    />
                                    <Form.Field
                                                id='form-input-control-qty'
                                                control={Input}
                                                label='Customer ID'
                                                placeholder='Customer code'
                                    />
                                </Form.Group>
                                <Form.Group style={{margin:"20px 0 0 13vw"}}>
                                    <Form.Field
                                        id='form-input-control-desc'
                                        control={Input}
                                        placeholder='item description'
                                    />
                                    <Form.Field style={{width:"21vw"}}
                                        control={Input}
                                        placeholder='Description'
                                        id='form-input-control-name'
                                    />
                                    <Form.Field
                                                id='form-input-control-qty'
                                                control={Input}
                                                placeholder='item quantity'
                                    />
                                    <Form.Field style={{width:"21vw"}}
                                                id='form-input-control-unitPrice'
                                                control={Input}
                                                placeholder='Unit Price'
                                    />
                                    <Form.Field
                                                id='form-button-control-clear'
                                                control={Button}
                                                content='Add To Cart'
                                    />
                                </Form.Group>
                            </Form>
                        </Grid.Row>
                        <Grid.Row>
                            <Table celled style={{width:"90vw", marginLeft:"4vw"}}>
                                <Table.Header>
                                    <Table.Row>
                                        <Table.HeaderCell>Product ID</Table.HeaderCell>
                                        <Table.HeaderCell>Product Name</Table.HeaderCell>
                                        <Table.HeaderCell>Qty</Table.HeaderCell>
                                        <Table.HeaderCell>Unit Price</Table.HeaderCell>
                                    </Table.Row>
                                </Table.Header>

                                <Table.Body>
                                    <Table.Row>
                                        <Table.Cell>Product ID</Table.Cell>
                                        <Table.Cell>Product Name</Table.Cell>
                                        <Table.Cell>Qty</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jamie</Table.Cell>
                                        <Table.Cell>Approved</Table.Cell>
                                        <Table.Cell>Requires call</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jill</Table.Cell>
                                        <Table.Cell>Denied</Table.Cell>
                                        <Table.Cell>None</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row >
                                        <Table.Cell>John</Table.Cell>
                                        <Table.Cell>No Action</Table.Cell>
                                        <Table.Cell>None</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jamie</Table.Cell>
                                        <Table.Cell >Approved</Table.Cell>
                                        <Table.Cell >Requires call</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                    <Table.Row>
                                        <Table.Cell>Jill</Table.Cell>
                                        <Table.Cell >Denied</Table.Cell>
                                        <Table.Cell>None</Table.Cell>
                                        <Table.Cell>Unit Price</Table.Cell>
                                    </Table.Row>
                                </Table.Body>
                            </Table>
                        </Grid.Row>
                        <Grid.Row>
                            <Input disabled placeholder='Total' style={{margin:"10px 0 0 75vw", width:"19vw"}}/>
                            <Form.Field style={{margin:"10px 0 0 75vw", width:"19vw"}}
                                        id='form-button-control-process'
                                        control={Button}
                                        content='Process'
                            />
                            <Form.Field style={{margin:"10px 0 0 75vw", width:"19vw"}}
                                        id='form-button-control-clear'
                                        control={Button}
                                        content='Clear'
                            />
                        </Grid.Row>
                    </Grid>
                </div>
            )}
        </div>
    );
}

export default ReportPage;